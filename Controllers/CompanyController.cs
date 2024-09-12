﻿using CompanyAnalysisApp.Services;
using Microsoft.AspNetCore.Mvc;

public class CompanyController : Controller
{
    private readonly CompanyAnalyzerService _companyAnalyzerService;

    public CompanyController(CompanyAnalyzerService companyAnalyzerService)
    {
        _companyAnalyzerService = companyAnalyzerService;
    }

    public IActionResult Index()
    {
        var largestCompany = _companyAnalyzerService.GetLargestCompany();
        return Content($"The most largest company is: {largestCompany}");
    }
}