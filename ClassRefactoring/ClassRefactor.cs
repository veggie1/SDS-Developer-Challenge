using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType)
        {
            switch (swallowType)
            {
                case SwallowType.African:
                    return new AfricanSwallow();
                case SwallowType.European:
                    return new EuropeanSwallow();
                default:
                    throw new InvalidOperationException($"Swallow type not allowed: {swallowType}");
            }
        }
    }

    public class AfricanSwallow : Swallow
    {
        public AfricanSwallow()
        {
            AirSpeedVelocity = 22;
        }
    }

    public class EuropeanSwallow : Swallow
    {
        public EuropeanSwallow()
        {
            AirSpeedVelocity = 20;
        }
    }

    public abstract class Swallow
    {
        public SwallowLoad Load { get; private set; }

        protected double AirSpeedVelocity;

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            switch (Load)
            {
                case SwallowLoad.None:
                    return AirSpeedVelocity;
                case SwallowLoad.Coconut:
                    return AirSpeedVelocity - 4;
                default:
                    throw new InvalidOperationException($"Applied load is invalid: {Load}");
            }
        }
    }
}