using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
            // 1) declare enum ComputerType
            
        enum ComputerType
        {

            Desktop,
            Laptop,
            Server
        };

        
        // 2) declare struct Computer
        
            //структура написана в другом файле но я не понимаю почему не работает 


        struct Computer
        {
            public int CPU;
            public double HGz;
            public int Memory_gb;
            public int HDD_gb;
            public ComputerType computerType;
        }

                       

        static void Main(string[] args)
        {



         




            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] departmentComputers = new Computer[4][];
            

            // 4) set the size of every array in jagged array (number of computers)



            Computer Desktop = new Computer
            {
               computerType = ComputerType.Desktop,
                CPU=2,
                HGz=1.7,
                Memory_gb=6,
                HDD_gb=500,
             };

            Computer Laptop = new Computer
            {
                computerType = ComputerType.Laptop,
                CPU = 4,
                HGz = 2.5,
                Memory_gb = 4,
                HDD_gb = 750,
            };

            Computer Server = new Computer
            {
                computerType = ComputerType.Server,
                CPU = 8,
                HGz = 3,
                Memory_gb = 16,
                HDD_gb = 1225,
            };






            // 5) initialize array
            // Note: use loops and if-else statements

            departmentComputers[0] = new Computer[2] { Laptop, Server };
            departmentComputers[1] = new Computer[1] { Server };
            departmentComputers[2] = new Computer[3] { Desktop, Server, Laptop };
            departmentComputers[3] = new Computer[4] { Desktop, Server, Laptop, Laptop };


            // 6) count total number of every type of computers



            int totalDesktopCOunt = 0;
            int totalLaptopCOunt = 0;
            int totalServerCOunt = 0;


            for (int i = 0; i < departmentComputers.Length; i++)
            {
                for (int j = 0;j < departmentComputers[i].Length;j++)
                {
                    switch (departmentComputers[i][j].computerType)
                    {
                        case ComputerType.Desktop:
                            totalDesktopCOunt++;
                            break;
                            case ComputerType.Laptop:
                            totalLaptopCOunt++; 
                            break;
                            case ComputerType.Server:
                            totalServerCOunt++; 
                            break;
                    }
                }
            }
            Console.WriteLine("totalDesktopCOunt\t" + totalDesktopCOunt);
            Console.WriteLine("totalLaptopCOunt\t" + totalLaptopCOunt);
            Console.WriteLine("totalServerCOunt\t" + totalServerCOunt);





            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            int totalComputers = 0;

            for (int i = 0; i< departmentComputers.Length;i++)
            {
                totalComputers += departmentComputers[i].Length;
            }
            Console.WriteLine("total Computer {0}", totalComputers);


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            int maxHDD = 0;
            int indexI = -1;
            int indexJ = -1;

            for (int i = 0;i< departmentComputers.Length;i++)
            {
                for (int j = 0; j< departmentComputers[i].Length;j++)
                {
                    if (maxHDD< departmentComputers[i][j].HDD_gb)
                    {
                        maxHDD = departmentComputers[i][j].HDD_gb;
                        indexI = i;
                        indexJ = j;
                    }
                }
            }
            Console.WriteLine("maxHDD - {0}", maxHDD);
            Console.WriteLine("indexI - {0}\tindexJ - {1}", indexI,indexJ);

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            int CPUmin = 100;
            int Memorymin = 10000;
            int indexA = -1;
            int indexB = -1;

            for(int i = 0; i < departmentComputers.Length; i++)
            {
                for (int j = 0; j < departmentComputers[i].Length; j++)
                {
                    if ((CPUmin > departmentComputers[i][j].CPU) && (Memorymin > departmentComputers[i][j].Memory_gb)) 
                    {

                        CPUmin = departmentComputers[i][j].CPU;
                        Memorymin = departmentComputers[i][j].Memory_gb;

                        indexA = i;
                        indexB = j;
                    }
                }
            }

            Console.WriteLine("CPUmin - {0} Memorymin - {1}",CPUmin, Memorymin);
            Console.WriteLine("indexA - {0} indexB - {1}",indexA, indexB);



            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            for (int i = 0;i< departmentComputers.Length;i++)
            {
                for (int j = 0; j< departmentComputers[i].Length; j++)
                {
                    if (departmentComputers[i][j].computerType==ComputerType.Desktop)
                    {
                        departmentComputers[i][j].Memory_gb = 8;
                    }
                }
            }

            Console.ReadLine();
        }

    }
}
