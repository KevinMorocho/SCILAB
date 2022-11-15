x= [-2:0.1:2];
function [z]=fun3(x)
z=7*x^2-4*x-6;
endfunction
clf(1);
xlabel("eje x", "fontsize", 2);
ylabel("eje y", "fontsize", 2);
xgrid();
plot(x, fun3(x),"r:");
title("Gráfica de la funcion 2*x^2-4*x-6", "fontsize", 2);

