﻿//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

using System;
using System.Text.RegularExpressions;

class HtmlReplaceTag
{
    static void Main()
    {
        string html = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

        string regex = @"<\s*a\s[^>]*\bhref\s*=\s*('(?<hyperlink>[^']*)'|""(?<hyperlink>[^""]*)""|(?<hyperlink>\S*))[^>]*>(?<hyperlinktext>(.|\s)*?)<\s*/a\s*>";

        Console.WriteLine(Regex.Replace(html,regex,m => "[URL=" + m.Groups["hyperlink"].Value + "]" + m.Groups["hyperlinktext"].Value + "[/URL]"));
    }
}
