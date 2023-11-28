
class Pro
{
    interface Builder
    {
        public void reset();
        public void setSeats(int number);
        public void setEnigne(SportsEnigne sportsEnigne);
        public void setTripComputer();
        public void setGPS();
    }
    public class SportsEnigne { }

    class Car { }
    class Manual { }

    class CarBuilder : Builder
    {
        private Car? car;
        public void reset() { }
        

        public void setEnigne(SportsEnigne sportsEnigne) { }
       

        public void setGPS() { }
        

        public void setSeats(int number) { }
       

        public void setTripComputer() { }
       

        public Car getResault()
        {
            return car!;
        }
    }

    class CarManualBuilder : Builder
    {
        private Manual? manual;

        public void reset()
        {
            this.manual = new Manual();
        }

        public void setEnigne(SportsEnigne sportsEnigne)
        {
            throw new NotImplementedException();
        }

        public void setGPS()
        {
            throw new NotImplementedException();
        }

        public void setSeats(int number)
        {
            throw new NotImplementedException();
        }

        public void setTripComputer()
        {
            throw new NotImplementedException();
        }

        public Manual getManual()
        {
            return this.manual!;
        }
    }

    class Director
    {
        public void makeSUV(Builder builder) { }
        public void makeSuportsCar(Builder builder)
        {
            builder.reset();
            builder.setSeats(2);
            builder.setEnigne(new SportsEnigne());
            builder.setTripComputer();
            builder.setGPS();
        }

    }


    static void Main(string[] args)
    {
        Director director = new Director();
        CarBuilder builder = new CarBuilder();
        director.makeSuportsCar(builder);
        Car car = builder.getResault();

    }
}
