// ## Objetivo

// Crie uma variável para armazenar o nome e a quantidade de experiência (XP) de um herói, depois utilize uma estrutura de decisão para apresentar alguma das mensagens abaixo:

// Se XP for menor do que 1.000 = Ferro
// Se XP for entre 1.001 e 2.000 = Bronze
// Se XP for entre 2.001 e 5.000 = Prata
// Se XP for entre 5.001 e 7.000 = Ouro
// Se XP for entre 7.001 e 8.000 = Platina
// Se XP for entre 8.001 e 9.000 = Ascendente
// Se XP for entre 9.001 e 10.000= Imortal
// Se XP for maior ou igual a 10.001 = Radiante

// ## Saída

// Ao final deve se exibir uma mensagem:
// "O Herói de nome **{nome}** está no nível de **{nivel}**"


using static System.Console;
WriteLine("Hello, Hero!");

string heroi = "Cavaleiro Solar";
int xp = 5000;
string nivel = "";

if(xp < 1000) nivel = "Ferro";
else if (xp >= 1000 && xp < 2000) nivel = "Bronze";
else if (xp >= 2000 && xp < 5000) nivel = "Prata";
else if (xp >= 5000 && xp < 7000) nivel = "Ouro";
else if (xp >= 7000 && xp < 8000) nivel = "Platina";
else if (xp >= 8000 && xp < 9000) nivel = "Ascendente";
else if (xp >= 9000 && xp < 10000) nivel = "Imortal";
else if (xp > 10000) nivel = "Radiante";

WriteLine($"O Heroi {heroi} está no nivel de {nivel}");