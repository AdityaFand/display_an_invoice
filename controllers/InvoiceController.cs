
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {

            // fetchInvoiceListFromDB();
            List<Item> items= new List<Item>
            {
                new Item { name = "Widget A", price = 19.99 },
                new Item { name = "Widget B", price = 29.99 }
            };
            if (items.Count != 0)
            {
                return Ok(new { items });
            }
            return NotFound("No invoice found");
        }

        // public void fetchInvoiceListFromDB(){
        //     string connectionString = "Server=localhost:3307;Database=invoice_db;User ID=root;Password=root;";

        //     using (MySqlConnection conn = new MySqlConnection(connectionString))
        //     {
        //         try
        //         {
        //             conn.Open();
        //             Console.WriteLine("Connection successful!");
        //             string query = "SELECT * FROM invoiceitems";
        //             MySqlCommand cmd = new MySqlCommand(query, conn);
        //         }
        //         catch (Exception ex)
        //         {
        //             Console.WriteLine("Error: " + ex.Message);
        //         }
        //     }
        // }
    }       

        public class Item
        {
            public string name { get; set; }
            public double price { get; set; }
        }
}
