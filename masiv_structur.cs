using System;

namespace KR{
    struct Plane{ // creating a structure with flight parameters
        public string flight; // flight name
        public string destination; // destination
        public int seats; // number of available seats

        public Plane(string flight, string destination, int seats){ // structure constructor
            this.flight = flight;
            this.destination = destination;
            this.seats = seats;
        }
        public void WritePlane(int num){ // output parameters
            Console.WriteLine($"Flight №{num + 1} : {flight};");
            Console.WriteLine($"Destination: {destination};");
            Console.WriteLine($"Number of available seats: {seats};");
        }
    }
    struct Date{ // creating a structure with the flight date
        public int day, month, hour, minute; // day, month, hour and minutes of departure

        public Date(int day, int month, int hour, int minute){ // structure constructor
            this.day = day;
            this.month = month;
            this.hour = hour;
            this.minute = minute;
        }
        public void WriteDate(){ // output parameters
            Console.WriteLine($"Departure date and time: {day}.{month} {hour}:{minute};");
        }
    }
    class Program{
        static void Main(string[] args){
            Plane[] flights = new Plane[] { // initializing an array of structures with parameters
                new Plane() {flight = "GH-327", destination = "Kyiv", seats = 10},
                new Plane() {flight = "JD-567", destination = "Lviv", seats = 1},
                new Plane() {flight = "BS-603", destination = "Odessa", seats = 15},
                new Plane() {flight = "BS-204", destination = "Odessa", seats = 0},
                new Plane() {flight = "RM-701", destination = "Berlin", seats = 6},
                new Plane() {flight = "US-517", destination = "New-York", seats = 0},
                new Plane() {flight = "GH-342", destination = "Kyiv", seats = 5},
            };
            Date[] dates = new Date[] { // initializing an array of structures with parameters
                new Date() {day = 14, month = 05, hour = 12, minute = 10},
                new Date() {day = 15, month = 05, hour = 8, minute = 50},
                new Date() {day = 14, month = 05, hour = 10, minute = 40},
                new Date() {day = 01, month = 06, hour = 9, minute = 10},
                new Date() {day = 19, month = 05, hour = 18, minute = 10},
                new Date() {day = 20, month = 05, hour = 20, minute = 19},
                new Date() {day = 14, month = 05, hour = 12, minute = 00},
            };
            Date pDate;

            Console.Write("Enter your destination point: "); // user input for the flight request
            string pdestination = Console.ReadLine();

            Console.Write("Enter how many tickets you need: ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----Enter date and time of departure----");
            Console.Write($"Departure day: ");
            pDate.day = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Departure month: ");
            pDate.month = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Departure hour: ");
            pDate.hour = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Departure minute: ");
            pDate.minute = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are some suitable flights by the end of this month:");
            bool b = false;

            for (int j = 0; j < flights.Length; j++){ // checking for suitable flights
                if (pdestination == flights[j].destination){
                    if (pDate.day <= dates[j].day && pDate.month == dates[j].month){
                        if (pDate.hour <= dates[j].hour && pDate.minute <= dates[j].minute){
                            if (tickets <= flights[j].seats){
                                flights[j].WritePlane(j);
                                dates[j].WriteDate();
                                b = true;
                            }
                        }
                    }
                }
            }

            if (b == false){ // output if no flights are found
                Console.WriteLine("Sorry, but there are no suitable flights");
            }
        }
    }
}
