﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsExample.Visitor.DocumentSample.Element;

namespace DesignPatternsExample.Visitor.DocumentSample.Visitors.Printer
{
    public class SamsungPrinterVisitor : IPrinterVisitor
    {
        public string Print(BlackWhiteDocument blackWhiteDocument)
        {
            return "Printing BlackWhiteDocument with SamsungPrinter";
        }

        public string Print(ColoredDocument coloredDocument)
        {
            return "Printing ColoredDocument with SamsungPrinter";
        }

        public string Print(SecretDocument secretDocument)
        {
            return "Printing SecretDocument with SamsungPrinter";
        }
    }
}
