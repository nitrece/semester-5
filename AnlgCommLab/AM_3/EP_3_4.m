% Exercise Problem 3.4
% --------------------
clc;
clear all;
close all;

% Details given in the question
Fc = 25;
t0 = 4;
a = 0.1 : 0.01 : 0.9;

% Assumed values
Tstart = -6;
Tstop = 6;
Fs = 250;

% Generating time
Ts = 1 / Fs;
t = Tstart : Ts : Tstop;
N = length(t);

% Generating the message signal
tk = mod(t - (t0/2), t0) - (t0/2);
m_t = (sin(pi*10*tk) ./ (pi*tk)) .^ 2;
for i = 1 : N
    if(isnan(m_t(1, i)))
        m_t(1, i) = 100;
    end
end
figure;
subplot(2,1,1);
plot(t, m_t);
ylim([-1.5 102.5]);
title('Message Signal');
xlabel('Time (s)');
ylabel('Amplitude');
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(m_t))));
title('Spectrum of Message Signal');
xlabel('Frequency (Hz)');
ylabel('Amplitude');

% Generating the carrier signal
c_t = cos(2*pi*Fc*t);
figure;
subplot(2,1,1);
plot(t, c_t);
title('Carrier Signal');
xlabel('Time (s)');
ylabel('Amplitude');
ylim([-1.5 1.5]);
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(c_t))));
title('Spectrum of Carrier Signal');
xlabel('Frequency (Hz)');
ylabel('Amplitude');

% Generating the modulated signal
ratio = zeros(1, length(a));
for i = 1 : length(a)
    if(mod(a(1, i), 0.1) == 0) 
        u_t = (2/a(1, i))*c_t + m_t.*c_t;
        figure;
        subplot(2,1,1);
        plot(t, u_t);
        title(sprintf('Modulated Signal (a = %f)', a(1, i)));
        xlabel('Time (s)');
        ylabel('Amplitude');
        subplot(2,1,2);
        plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(u_t))));
        title(sprintf('Spectrum of Modulated Signal (a = %f)', a(1, i)));
        xlabel('Frequency (Hz)');
        ylabel('Amplitude');
    end
    ratio(1, i) = (a(1, i) ^ 2) / 2;
end
figure;
plot(a, ratio);
title('Power Content ratio of Sideband to Carrier');
xlabel('Modulation index (a)');
ylabel('Ratio');


% Calculate power
u_pow = sum(u_t .^ 2) / N;
fprintf(1, 'Power of modulated signal u(t) = %f\n', u_pow);
u_f_pow = sum(abs(fft(u_t)) .^ 2) / N;
m_f_pow = sum(abs(fft(m_t)) .^ 2) / N;
fprintf(1, 'Power spectral density of modulated signal u(f) = %f\n', u_f_pow);
fprintf(1, 'Power spectral density of message signal m(f) = %f\n\n', m_f_pow);

