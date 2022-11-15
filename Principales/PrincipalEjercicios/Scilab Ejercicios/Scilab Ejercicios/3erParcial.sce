
anio=input("Anio a comparar: ");

A= modulo(anio, 19);
B= modulo(anio, 4);
C= modulo(anio, 7);
D= modulo((19*A+24),30);
E= modulo((2*B+4*C+6*D+5),7);
N= 22 +D+ E;

if (N<=31) then
    printf("El domingo le corresponde a marzo");     
else
    printf("El domingo le corresponde a abril");     
end
