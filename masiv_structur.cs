using System;

namespace KR{
    struct Plane{ // створення структури з параметрами рейсу
        public string flight; // ім'я рейсу
        public string destination; // місце призначення
        public int seats; // кількість вільних місць

        public Plane(string flight, string destination, int seats){ // конструктор структури
            this.flight = flight;
            this.destination = destination;
            this.seats = seats;
        }
        public void WritePlane(int num){ // вивід параметрів
            Console.WriteLine($"Flight №{num + 1} : {flight};");
            Console.WriteLine($"Destination: {destination};");
            Console.WriteLine($"Number of available seats {seats};");
        }
    }
    struct Date{ // створення структури з датою рейса
        public int day, month, hour, minute; // день, місяц, година та хвилини відправлення

        public Date(int day, int month, int hour, int minute){ // конструктор структури
            this.day = day;
            this.month = month;
            this.hour = hour;
            this.minute = minute;
        }
        public void WriteDate(){ // вивід параметрів
            Console.WriteLine($"Departure date and time: {day}.{month} {hour}:{minute};");
        }
    }
    class Program{
        static void Main(string[] args){
            Plane[] flights = new Plane[] { // запевнення масиву структур параметрами
                new Plane() {flight = "GH-327", destination = "Kyiv", seats = 10},
                new Plane() {flight = "JD-567", destination = "Lviv", seats = 1},
                new Plane() {flight = "BS-603", destination = "Odessa", seats = 15},
                new Plane() {flight = "BS-204", destination = "Odessa", seats = 0},
                new Plane() {flight = "RM-701", destination = "Berlin", seats = 6},
                new Plane() {flight = "US-517", destination = "New-York", seats = 0},
                new Plane() {flight = "GH-342", destination = "Kyiv", seats = 5},
            };
            Date[] dates = new Date[] { // запевнення масиву структур параметрами
                new Date() {day = 14, month = 05, hour = 12, minute = 10},
                new Date() {day = 15, month = 05, hour = 8, minute = 50},
                new Date() {day = 14, month = 05, hour = 10, minute = 40},
                new Date() {day = 01, month = 06, hour = 9, minute = 10},
                new Date() {day = 19, month = 05, hour = 18, minute = 10},
                new Date() {day = 20, month = 05, hour = 20, minute = 19},
                new Date() {day = 14, month = 05, hour = 12, minute = 00},
            };
            Date pDate;

            Console.Write("Enter your destination point: "); // введення користувачем запиту на рейс
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

            for (int j = 0; j < flights.Length; j++){ // перевірка на підходящість рейсу
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

            if (b == false){ // виввід у випадку, якщо рейс не знайдено
                Console.WriteLine("Sorry, but there are no suitable flights");
            }
        }
    }
}
