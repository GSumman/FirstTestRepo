using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

[TestFixture]

public class TestProgram

{

private IWebDriver driver;

[SetUp]

public void SetupTest()

{

driver = new ChromeDriver();

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

driver.Url = "https://code.visualstudio.com/";

}

[Test]

public void testMethod()

{

String title = driver.Title;

System.Console.WriteLine("title of site is :" +title);

}

[TearDown]

public void TeardownTest()

{

driver.Quit();

}

}

