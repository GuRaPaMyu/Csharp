#include <stdio.h>
#include <math.h>
#include <stdlib.h>

#define PARTS 1000

int main (int argv, char *argc[])
{
  int i;
  FILE *fp;
  double inc_rate;

  inc_rate = M_PI * 2 / PARTS;
  fp = fopen(argc[1] , "w");


  for(i=0;i<PARTS;i++)
    {
      fprintf(fp, "%.5f\n", sin(inc_rate * i));
    }
  fclose(fp);
  return 0;
}
