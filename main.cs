using System;

class MainClass {
  public static void Main (string[] args) {
    
    int [,] matriz = new int[3,5]{{4, 3, 2, 7, 5}, {3, 2, 1, 3, 7}, {6, 4, 0, 8, 9}};

  int qtdLinhas = 3, qtdColunas = 5;

  for (int i = 0; i<qtdLinhas; i++){
    for(int j = 0; j<qtdColunas; j++){
      Console.WriteLine("Elementos [{0},{1}]: {2}", i,j, matriz[i,j]);
    }
  }  

  }
}