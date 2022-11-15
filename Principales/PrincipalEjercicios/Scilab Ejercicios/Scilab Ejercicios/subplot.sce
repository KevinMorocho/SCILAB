

function z=xx2(x)
z=(x^2+4*x+5);
endfunction
x= [-20:0.5:20];
subplot (1,3,2);
plot(x, xx2(x),"r:");
xgrid(2,1,3);
xlabel("eje x", "fontsize", 2);
ylabel("eje y", "fontsize", 2);
title("Gráfica  x2+4x+5", "fontsize", 2);



function z=xx3(x)
z=((x^2)/(7-2*x));
endfunction
x= [-20.1:-1];
subplot (1,3,3);
plot(x, xx3(x),"r:");
xgrid(2,1,3);
xlabel("eje x", "fontsize", 2);
ylabel("eje y", "fontsize", 2);
title("Gráfica  x2/(-2x+7)", "fontsize", 2);

