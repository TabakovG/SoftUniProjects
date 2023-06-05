using System.Text;
using System.Text.Json;
using Microsoft.Net.Http.Headers;
using MVC_Demo.Models.Product;

namespace MVC_Demo.Controllers;

using Microsoft.AspNetCore.Mvc;
public class ProductController : Controller
{
	private IEnumerable<ProductViewModel> _products = new HashSet<ProductViewModel>()
	{
		new ProductViewModel()
		{
			Id = 1,
			Name = "Cheese",
			Price = 4.33m
		},
		new ProductViewModel()
		{
			Id = 2,
			Name = "Ham",
			Price = 3.43m
		},
		new ProductViewModel()
		{
			Id = 3,
			Name = "Bread",
			Price = 1.50m
		}
	};
	[ActionName("My-Products")]
	public IActionResult All(string keyword)
	{
		if (keyword != null)
		{
			var foundProducts = _products
				.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
			return View(foundProducts);
		}
		return View(_products);
	}

	public IActionResult ById(int Id)
	{
		var product = _products.FirstOrDefault(x => x.Id == Id);
		if (product == null)
		{
			return RedirectToAction("My-Products", "Product");
		}
		return View(product);
	}

	public IActionResult AllAsJson()
	{
		var options = new JsonSerializerOptions
		{
			WriteIndented = true
		};
		return Json(_products, options);
	}

	public IActionResult AllAsText()
	{
		var sb = new StringBuilder();
		foreach (var item in _products)
		{
			sb.AppendLine($"Product {item.Id}: {item.Name} - {item.Price} lv.");
		}

		return Content(sb.ToString().Trim());
	}
	public IActionResult AllAsTextFile()
	{
		var sb = new StringBuilder();
		foreach (var item in _products)
		{
			sb.AppendLine($"Product {item.Id}: {item.Name} - {item.Price} lv.");
		}

		Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment;filename=products.txt");

		return File(Encoding.UTF8.GetBytes(sb.ToString().Trim()), "text/plain");
	}
}
