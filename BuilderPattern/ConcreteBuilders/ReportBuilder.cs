using BuilderPattern.Models;
using System;

namespace BuilderPattern.ConcreteBuilders
{
    public class ReportBuilder : IBuilder
    {
        private Report _report;

        public Report Report
        {
            set { _report = value; }
        }

        public ReportBuilder()
        {
            this.Reset();
        }

        private void Reset()
        {
            this._report = new Report();
        }

        public IBuilder AddDescription()
        {
            _report.Description = "This is descripton";
            return this;
        }

        public IBuilder AddFooter()
        {
            _report.Footer = "this is footer";
            return this;
        }

        public IBuilder AddTitle()
        {
            _report.Title = "this is title";
            return this;
        }

        public Report GetReport()
        {
            var result = _report;
            Reset();
            return result;
        }

        public override string ToString()
        {
            return _report.Title + Environment.NewLine +
                _report.Description + Environment.NewLine + _report.Footer;
        }
    }
}