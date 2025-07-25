﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelCommon
{
    public interface IMarkdownGenerator
    {
        /// <summary>
        /// Converts the markdown text to html
        /// The Id of all elements has to be the corresponding line number in markdown text
        /// </summary>
        /// <param name="markDownText"></param>
        /// <param name="filepath"></param>
        /// <param name="supportEscapeCharsInUris"></param>
        /// <returns>html formatted text</returns>
        string ConvertToHtml(string markDownText, string filepath, bool supportEscapeCharsInUris);
    }
}
