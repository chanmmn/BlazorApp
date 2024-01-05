using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class PeopleService
    {
        public Task<PersonModel[]> GetPeopleAsync(DateTime startDate)
        {
            PersonModel[] personModels = { new PersonModel() { FirstName = "John", LastName = "Yu", AccountBalance = "50" },
                                           new PersonModel() { FirstName = "Ming", LastName = "Man", AccountBalance = "50" }} ;

            Task<PersonModel[]> task = Task.FromResult(personModels);
            //return personModels;
            return task;
        }

        public Task<ProductModel[]> GetProductAsync(DateTime startDate)
        {
            ProductModel[] productModels = new ProductModel[5];
            ProductModel productModel = new ProductModel();
            int counter = 0;

            string strConn = "Server=.;Database=Northwind;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(strConn);
            string sql = "Select TOP 5 ProductName, UnitPrice From Products";
            SqlCommand command = new SqlCommand(sql, conn);
            
            //opening connection and executing the query
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                //Console.WriteLine("{0}", dr[1].ToString());
                productModel = new ProductModel();
                productModel.ProductName = dr[0].ToString();
                productModel.UnitPrice = dr[1].ToString();
                productModels[counter] = productModel;
                counter++;
            }
            conn.Close();

            Task<ProductModel[]> task = Task.FromResult(productModels);
            //return personModels;
            return task;
        }
    }
}
