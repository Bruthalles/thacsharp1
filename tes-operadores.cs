using System;

int a = 5;
int b = 4;
int c = 2;
int d = 6;
int e = 8;

int adicao(){
    int soma = a+b;
    return soma;    
}

int divisao(){ 
    int div = d / e; 
    return div;    
}
int calculo(){
    int result = adicao() * c - divisao();
    return result;
}
int testmais  = (a+b) * c - d/ e;
int testmenos =  a+b  *(c-d) / e;
int testvezes =  a+(b * c)- d/ e;
int testdivi  =  a+b  * c -(d/e);

Console.WriteLine($"teste na fução: adicao(a+b) x c - divisao(d/e) = {calculo()}");

Console.Write("teste puro: ");
Console.WriteLine($"{a}+{b}x{c}-{d}/{e} = {a+b*c-d/e}");

Console.WriteLine("testando parenteses isolados -");

Console.WriteLine($"({a}+{b}) x {c} - {d} / {e} = {testmais}");

Console.WriteLine($"{a} + {b} x ({c}-{d}) / {e} = {testmenos}");

Console.WriteLine($"{a} + ({b}x{c}) - {d} / {e} = {testvezes}");

Console.WriteLine($"{a} + {b} x {c} - ({d}/{e}) = {testdivi}");


