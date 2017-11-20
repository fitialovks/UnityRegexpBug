using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;
using UnityEngine;

public class RegexTest {

    [Test]
    public void Full()
    {
        string source = "1234567890";
        int index = 0;
        var regex = new Regex("[34]+");
        var match = regex.Match(source, index, source.Length - index);
        Assert.IsTrue(match.Success);
        Assert.AreEqual("34", match.Value);
    }

    [Test]
    public void Part()
    {
        string source = "1234567890";
        int index = 3;
        var regex = new Regex("[34]+");
        var match = regex.Match(source, index, source.Length - index);
        Assert.IsTrue(match.Success);
        Assert.AreEqual("4", match.Value);
    }

    [Test]
    public void None()
    {
        string source = "1234567890";
        int index = 4;
        var regex = new Regex("[34]+");
        var match = regex.Match(source, index, source.Length - index);
        Assert.IsFalse(match.Success);
    }
}
