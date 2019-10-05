using System;
using Exemplo03_Erros_Personalizados.Entities;
using Exemplo03_Erros_Personalizados.Entities.Exceptions;

namespace Exemplo03_Erros_Personalizados
{
    class Program {
        static void Main(string[] args) {

            try {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e) {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e) { //Erro personalizado
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e) { //Tipo mais genérico
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
