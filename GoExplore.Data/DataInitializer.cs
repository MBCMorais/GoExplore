using GoExplore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoExplore.Data
{
    public static class DataInitializer
    {


        public static void Initialize(this DataContext dbContext)
        {


            if (!dbContext.Customer.Any())
            {
                dbContext.Customer.Add(new Customer
                {
                    Age = 28,
                    FirstName = "Marcelo",
                    LastName = "Morais",
                    NumeroContribuinte = 987653210,
                    Address = "",
                    City = "",
                    Country = "",
                    Zipcode = "",
                    Email = "",
                    Phone = 123456789,


                });
                dbContext.SaveChanges();
            }


            if (!dbContext.RoomTypes.Any())
            {
                dbContext.RoomTypes.Add(new RoomType
                {

                    Name = "estudio"
                });
                dbContext.RoomTypes.Add(new RoomType
                {

                    Name = "casa"
                });
                dbContext.SaveChanges();
            }


            if (!dbContext.Rooms.Any())
            {
                dbContext.Rooms.Add(new Room
                {

                    Price = 200,
                    Rate = 2,
                    Number = "120",
                    Description = "",

                });
                dbContext.Rooms.Add(new Room
                {

                    Price = 200,
                    Rate = 2,
                    Number = "1",
                    Description = "",
                }
                );
                dbContext.Rooms.Add(new Room
                {

                    Price = 120,
                    Rate = 2,
                    Number = "120",
                    Description = "",

                });
                dbContext.SaveChanges();
            }

            if (!dbContext.Reservations.Any())
            {
                dbContext.Reservations.Add(new Reservation
                {

                    DateIn = DateTime.Now.AddDays(-10),
                    DateOut = DateTime.Now.AddDays(-1)


                });
                dbContext.Reservations.Add(new Reservation
                {

                    DateIn = DateTime.Now.AddDays(-5),
                    DateOut = DateTime.Now.AddDays(-2),
                   
                    Room = new Room
                    {
                        Id = 1,
                        Price = 120,
                        Rate = 4,
                        RoomTypes = {
                            new RoomType{
                                Id=1,
                                Name="teste"
                            },
                        }

                    }
                });

                
                dbContext.SaveChanges();
            }


        }
        
    }
}
