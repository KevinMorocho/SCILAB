dig=input("Escriba valor:");
re=0;
valor=dig;
while(valor>0)
   h=(modulo(valor,10));
   valor=int(valor/10);
   re=re*10+int(h);  
end
if dig<>re then
    disp("Es palindromo ");
else
end

if dig<>re then
    disp("No es palindromo ");
else
end
