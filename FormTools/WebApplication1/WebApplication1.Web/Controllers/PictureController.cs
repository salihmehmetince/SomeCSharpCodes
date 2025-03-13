using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Formats.Jpeg;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PictureController : Controller
{
    private readonly IWebHostEnvironment _webHostEnvironment;

    public PictureController(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }

    [HttpGet]
    public IActionResult Index()
    {
        string originalsPath = Path.Combine(_webHostEnvironment.WebRootPath, "images/originals/");
        string resizedPath = Path.Combine(_webHostEnvironment.WebRootPath, "images/resized/");

        if (!Directory.Exists(originalsPath) || !Directory.Exists(resizedPath))
        {
            return View(new Dictionary<string, List<string>>());
        }

        // Orijinal resimler
        var originalImages = Directory.GetFiles(originalsPath)
            .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png") || file.EndsWith(".jpeg") || file.EndsWith(".gif"))
            .Select(file => "/images/originals/" + Path.GetFileName(file))
            .ToList();

        // Değiştirilmiş resimler
        var resizedImages = Directory.GetFiles(resizedPath)
            .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png") || file.EndsWith(".jpeg") || file.EndsWith(".gif"))
            .Select(file => "/images/resized/" + Path.GetFileName(file))
            .ToList();

        var imagesDictionary = new Dictionary<string, List<string>>();

        foreach (var original in originalImages)
        {
            string baseName = Path.GetFileNameWithoutExtension(original);
            imagesDictionary[original] = resizedImages.Where(resized => resized.Contains(baseName)).ToList();
        }

        return View(imagesDictionary);
    }

    [HttpPost]
    public async Task<IActionResult> ChangeResolutionAndSave(IFormFile imageFile)
    {
        if (imageFile == null || imageFile.Length == 0)
        {
            return RedirectToAction("Index");
        }

        string originalsPath = Path.Combine(_webHostEnvironment.WebRootPath, "images/originals/");
        string resizedPath = Path.Combine(_webHostEnvironment.WebRootPath, "images/resized/");

        if (!Directory.Exists(originalsPath))
        {
            Directory.CreateDirectory(originalsPath);
        }
        if (!Directory.Exists(resizedPath))
        {
            Directory.CreateDirectory(resizedPath);
        }

        string originalFilePath = Path.Combine(originalsPath, imageFile.FileName);

        using (var stream = new FileStream(originalFilePath, FileMode.Create))
        {
            await imageFile.CopyToAsync(stream);
        }

        using (var stream = imageFile.OpenReadStream())
        {
            using (var originalImage = await Image.LoadAsync(stream))
            {
                int[][] resolutions = new int[][]
                {
                    new int[] { 1920, 1080 },
                    new int[] { 1280, 720 },
                    new int[] { 640, 480 }
                };

                foreach (var res in resolutions)
                {
                    int width = res[0];
                    int height = res[1];

                    using (var resizedImage = originalImage.Clone(x => x.Resize(width, height)))
                    {
                        string resizedFileName = $"{Path.GetFileNameWithoutExtension(imageFile.FileName)}-{width}x{height}.jpg";
                        string resizedFilePath = Path.Combine(resizedPath, resizedFileName);

                        await resizedImage.SaveAsync(resizedFilePath, new JpegEncoder());
                    }
                }
            }
        }

        return RedirectToAction("Index");
    }
}
