printf("INGRESAR TERMINOS: "),
terminos=input("   :");
numerador =5;
resultado=0;
valor=2;
constante=4;

function [f]=factorial(n)
    f=1;
    for i=1:n
        f=f*i;
    end
  
endfunction
a=1:5;
if (n>=1 & n<=5) then
    for i=1:terminos
       x=x+((a^((terminos-i)(factorial(valor))))/(sqrt(constante(valor ^(terminos-i)))));     
       constante=constante +4;
       valor=valor+2; 
      end
end
disp(x);
