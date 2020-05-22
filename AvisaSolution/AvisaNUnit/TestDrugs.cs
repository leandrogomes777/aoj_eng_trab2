using AvisaSolution.Models;
using NUnit.Framework;
using System;

namespace AvisaNUnit
{
    public class TestDrugs
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateModelInstance()
        {
            User user = new User();
            Assert.Pass();
        }
    }
}