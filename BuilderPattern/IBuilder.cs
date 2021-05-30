using System;

namespace BuilderPattern
{
    public interface IBuilder
    {
        IBuilder AddTitle();

        IBuilder AddDescription();

        IBuilder AddFooter();
    }
}