int findFactorialBase(int factorial) {
  if (factorial < 1) {return -1;}
  int base = 1;

  
  do {
    if (factorial % base != 0) {return -1;}
    factorial = factorial/base;
    base = base + 1;
  } while(factorial > base );

  if (factorial == base) {
    return base;
  } else {return -1;}
}
