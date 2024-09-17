using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
         // This is a mock database for storing orders.
        // In a real application, this would interact with a real database.
        private static List<Order> Orders = new List<Order>();

        // GET: Order/Index
        // Displays a list of all orders
        public IActionResult Index()
        {
            return View(Orders);
        }

        // GET: Order/Create
        // Displays a form for creating a new order
        public IActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        // Handles the form submission for creating a new order
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                order.Id = Orders.Count + 1; // Generate a new ID
                Orders.Add(order); // Add the order to the mock database
                return RedirectToAction("Index");
            }

            // If the model state is invalid, redisplay the form with validation errors
            return View(order);
        }
    }

    }
}
