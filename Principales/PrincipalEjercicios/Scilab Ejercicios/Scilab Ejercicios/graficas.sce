//Grafica con tabla de valores
x= [-10:0.1:10];
function [z]=fun3(x)
z=3*x+2;
endfunction
disp("TABLA DE VALORES")
printf('Independientes(x) Dependientes(y) \n');
for i=-10:10
    printf(' %d             %d\n',i,fun3(i));
end

clf(1);
xlabel("eje x", "fontsize", 2);
ylabel("eje y", "fontsize", 2);
xgrid();
plot(x, fun3(x),"r:");
title("Gráfica de la funcion 3*x+2", "fontsize", 2);

