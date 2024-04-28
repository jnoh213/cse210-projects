using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // GRADING SCALE
        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60
        Console.Write("What is your Grade? ");
        string stringGrade= Console.ReadLine();
        int grade=int.Parse(stringGrade);
        string letter;
        string denominator="";
        if(grade>=90){
            letter="A";
            if(grade%10<=3){
                denominator="-";
            }
            else{
                denominator="";
            }
        }
        else if(grade>=80){
            letter="B";
            if(grade%10>=7){
                denominator="+";
            }
            else if(grade%10<=3){
                denominator="-";
            }
            else{
                denominator="";
            }
        }
        else if(grade>=70){
            letter="C";
            if(grade%10>=7){
                denominator="+";
            }
            else if(grade%10<=3){
                denominator="-";
            }
            else{
                denominator="";
            }
        }
        else if (grade>=60){
            letter="D";
            if(grade%10>=7){
                denominator="+";
            }
            else if(grade%10<=3){
                denominator="-";
            }
            else{
                denominator="";
            }
        }
        else{
            letter="F";
        }
        if(letter=="A" || letter=="B" ||letter=="C" || letter=="D"){
            
            Console.WriteLine($"You passed with a {letter}{denominator}.");
        }
        else{
            Console.WriteLine("Try Again, you got this!");
        }
    }
}