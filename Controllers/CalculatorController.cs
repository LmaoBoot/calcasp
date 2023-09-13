using Microsoft.AspNetCore.Mvc;
using System;

public class CalculatorController : Controller
{
    public IActionResult Index(string input)
    {
        if (!string.IsNullOrEmpty(input))
        {
            try
            {
                // Process the input and perform calculations in C#
                var result = ProcessInput(input);
                ViewBag.Result = result.ToString();
            }
            catch (Exception ex)
            {
                ViewBag.Result = "Error: " + ex.Message;
            }
        }

        // Redirect back to the same view or another view as needed
        return View(); 
    }

    private double ProcessInput(string input)
    {
        // Implement your logic to process user input and perform calculations here.
        // You can use the example from a previous response or any other method you prefer.

        // For example:
        if (double.TryParse(input, out double inputValue))
        {
            // Perform calculations or processing here as needed.
            return inputValue;
        }
        else
        {
            throw new ArgumentException("Invalid input");
        }
    }
}
