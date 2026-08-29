%option noyywrap

%{
#include <stdio.h>
#include<conio.h>
int vowels = 0, consonants = 0, words = 0, lines = 0;
int inword = 0;
%}

%%
[aeiouAEIOU]      {
                     vowels++;
                     if (!inword) {
                         words++;
                         inword = 1;
                     }
                  }

[b-df-hj-np-tv-zB-DF-HJ-NP-TV-Z] {
                     consonants++;
                     if (!inword) {
                         words++;
                         inword = 1;
                     }
                  }

[ \t]+            { inword = 0; }

\n                {
                     lines++;
                     inword = 0;
                  }

[^A-Za-z \t\n]+   { inword = 0; }

%%
int main(void)
{
    printf("Enter text (Press Ctrl+D on Linux/macOS or Ctrl+Z then Enter on Windows to finish):\n");

    yylex();

    printf("\n----- RESULTS -----\n");
    printf("Vowels     : %d\n", vowels);
    printf("Consonants : %d\n", consonants);
    printf("Words      : %d\n", words);
    printf("Lines      : %d\n", lines);
    getch();
    return 0;
}
