using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMR_Command {
    public class CalMove {
        public double lengthCar { get; set; }
        public int currentX { get; set; }
        public int currentY { get; set; }
        public int currentAngle { get; set; }
        public int targetX { get; set; }
        public int targetY { get; set; }
        public double calRSup { get; set; }
        public double calR { get; set; }
        public int iccX { get; set; }
        public int iccY { get; set; }
        public double angleStepping { get; set; }
        public double angleSteppingSup { get; set; }
        public int offsetAngleL { get; set; }
        public int offsetAngleR { get; set; }
        private double pluseStepping { get; set; }
        public bool flagControlAgain0x04 { get; set; }

        public void ClearValue() {
            currentX = 0;
            currentY = 0;
            currentAngle = 0;
            targetX = 0;
            targetY = 0;
            calRSup = 0;
            pluseStepping = 0.03;
        }
        public void CalIcc(byte cmd) {
            if (cmd == 0x03) {//ขวา
                if (currentAngle == 0) {
                    iccY = currentY - (int)lengthCar;
                    iccX = currentX - (int)calR;
                }

                if (currentAngle == 90) {
                    iccX = currentX + (int)calR;
                    iccY = currentY - (int)lengthCar;
                }

                if (currentAngle == 180) {
                    iccY = currentY - (int)lengthCar;
                    iccX = currentX + (int)calR;
                }

                if (currentAngle == -90) {
                    iccX = currentX - (int)calR;
                    iccY = currentY + (int)lengthCar;
                }
            }

            if (cmd == 0x04) {//ซ้าย
                if (currentAngle == 0) {
                    iccY = currentY + (int)calR;
                    iccX = currentX - (int)lengthCar;
                }

                if (currentAngle == 90) {
                    iccX = currentX - (int)calR;
                    iccY = currentY - (int)lengthCar;
                }

                if (currentAngle == 180) {
                    iccY = currentY - (int)calR;
                    iccX = currentX + (int)lengthCar;
                }

                if (currentAngle == -90) {
                    iccX = currentX + (int)calR;
                    iccY = currentY + (int)lengthCar;
                }
            }
        }
        public void CalAngleStepping(byte cmd) {
            double crossClose = calR / lengthCar;    //ข้าม / ชิด;  

            if (cmd == 0x03) {
                angleSteppingSup = ArcTan(crossClose);
                angleSteppingSup = angleSteppingSup - 90;
            }

            if (cmd == 0x04) {
                angleSteppingSup = ArcTan(crossClose);
                angleSteppingSup = 90 - angleSteppingSup;
            }

            angleStepping = angleSteppingSup;
        }
        public byte[] CalPluse() {
            double angleSup = angleStepping / pluseStepping;

            if (angleStepping >= 0) {
                angleSup += offsetAngleL;

            } else {
                angleSup += offsetAngleR;
            }

            Int16 angleInt16 = Convert.ToInt16(angleSup);
            byte[] angleByte = BitConverter.GetBytes(angleInt16);

            return angleByte;
        }


        private int ArcTan(double factor) {
            double radians = Math.Atan(factor);
            double angle = radians * (180 / Math.PI);

            return (int)angle;
        }
    }
}
