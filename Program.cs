
using System;

    string msg01 = "hello world";
    string msg02 = "bye world";
    string tudo = msg01 + msg02;
    bool diabom = true;

    for(int i=0; i==5; i++){

        if(diabom){
            Console.WriteLine(msg01);
            diabom = !diabom;
            
        }
        else{
            Console.WriteLine(msg02);
            diabom = !diabom;
            
        }

    }

    Console.WriteLine(tudo);

            


    