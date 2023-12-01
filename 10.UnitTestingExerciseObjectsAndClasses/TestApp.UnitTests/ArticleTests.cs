using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        this._article = new();
    }
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        string[] input = { 
            "Article Content Author", 
            "Article2 Content2 Author2", 
            "Article3, Content3, Author3" };

        Article result = _article.AddArticles(input);

        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        Article input = new Article()
        {
            ArticleList = new ()
            {
                new Article()
                {
                    Title = "Alabala",
                    Content = "Alabala is alabala",
                    Author = "AuthorAlabala"
                },
                new Article()
                {
                    Title = "bAlabala",
                    Content = "bAlabala is alabala",
                    Author = "bAuthorAlabala"
                },
                new Article()
                {
                    Title = "cAlabala",
                    Content = "cAlabala is alabala",
                    Author = "cAuthorAlabala"
                }
            }
            
        };

        string criteria = "title";
       
        string expected = $"Alabala - Alabala is alabala: AuthorAlabala{Environment.NewLine}" +
                          $"bAlabala - bAlabala is alabala: bAuthorAlabala{Environment.NewLine}" +
                          $"cAlabala - cAlabala is alabala: cAuthorAlabala";

        string result = _article.GetArticleList(input, criteria);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        Article input = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Title = "Alabala",
                    Content = "Alabala is alabala",
                    Author = "AuthorAlabala"
                },
                new Article()
                {
                    Title = "bAlabala",
                    Content = "bAlabala is alabala",
                    Author = "bAuthorAlabala"
                },
                new Article()
                {
                    Title = "cAlabala",
                    Content = "cAlabala is alabala",
                    Author = "cAuthorAlabala"
                }
            }

        };

        string criteria = "abc";

        string expected = string.Empty;

        string result = _article.GetArticleList(input, criteria);

        Assert.That(result, Is.EqualTo(expected));
    }
}
