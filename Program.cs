using System;

namespace Quiz2 {    
    class Program{
        static void Main(string[]args){
            Console.Write("N : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K : ");
            int k = int.Parse(Console.ReadLine());
            int gender, mscore, fscore;
            if (k <= (n / 2)){
                for (int order = 1; order <= n; order++){
                    Console.Write("Gender : ");
                    gender = int.Parse(Console.ReadLine());
                    Console.Write("Male score : ");
                    mscore = int.Parse(Console.ReadLine());
                    Console.Write("Female score : ");
                    fscore = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("{0} {1}",ShowGender ,ShowCommittee);
            }  
        }

        static int MaxSinger(int x){
            
        }

        static int HighScore(int x){
            if (x >= 9){
                return 1;
            }
        }

        static int SameScore(int x, int y){
            if (x == y){
                if (gender = 1){
                    return 1;
                }else {
                    return 2;
                }
            }
        }

        static int SameGender(int x){
            if 
        }

        static int ShowGender(int x){
            if (x == 1){
                return 1;
            }else{
                return 2;
            }
        }

        static int ShowCommittee(int x){

        }


    }
}