function y = am_envelope_detect(x, Ts, time_const)
% Function to simulate envelope detection
N = length(x);
y = zeros(1, N);
amp = 0;
tp = 0;
for i = 1 : N
    if(x(1, i) > (amp * exp(-tp / time_const)))
        amp = x(1, i);
        tp = 0;
    else
        tp = tp + Ts;
    end
    y(1, i) = amp * exp(-tp / time_const);
end
end
