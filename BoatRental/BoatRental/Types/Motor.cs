﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoatRental.Repository;

namespace BoatRental.Types
{
    class Motor
    {
        public int ID { get; private set; }
        public String Name { get; private set; }
        public double TankCapacity { get; private set; }

        private static DAL dal = new DAL(new OracleRepository());

        public Motor(int id, String name, double tankCapacity)
        {
            ID = id;
            Name = name;
            TankCapacity = tankCapacity;
        }

        public void SetName(String name)
        {
            dal.SetMotorName(name, ID);

            Name = name;
        }

        public void SetTankCapacity(double tankCapacity)
        {
            dal.SetMotorTankCapacity(tankCapacity, ID);

            TankCapacity = tankCapacity;
        }

        public static List<Motor> GetAllMotors()
        {
            return dal.GetAllMotors();
        }
    }
}
