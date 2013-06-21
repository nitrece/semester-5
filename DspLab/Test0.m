A = [1 2 3 4 5];
B = [2 3 4 5];
C = conv(A, B);
subplot(3,1,1); stem(A);
subplot(3,1,2); stem(B);
subplot(3,1,3); stem(C);
