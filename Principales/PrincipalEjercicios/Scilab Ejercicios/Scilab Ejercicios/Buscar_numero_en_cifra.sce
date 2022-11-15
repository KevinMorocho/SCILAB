dig1=input("Escriba el número: ");
buscar=input("Escriba la cifra: ");
final=0;
arra=[];
while(dig1<>0)    
    q= int(modulo(dig1,10));
    final=final+1;
    arra(final)= q;     
    dig1=int(dig1/10);    
end
multi=0;
for t=1:final
    if arra(t)==buscar then
        multi=multi+1;
    end
end 

if(multi>0) then
    disp("Si pertenece al número")
else
    disp("No pertenece al número")
end



