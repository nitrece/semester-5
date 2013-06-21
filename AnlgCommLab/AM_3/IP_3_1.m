% Illustrative Problem 3.1
% ------------------------
clc;
clear all;
close all;

% Details given in the question
Fc = 250;
t0 = 0.15;

% Assumed values
Tstart = 0;
Tstop = 1;
Fs = 2.5 * 10^3;

% Generating time
Ts = 1 / Fs;
t = Tstart : Ts : Tstop;
N = length(t);

% Generating the message signal
tk = mod(t, t0);
m_t = (tk <= (1/3)*t0) - 2*((tk > (1/3)*t0) .* (tk <= (2/3)*t0));
subplot(2,2,1);
plot(t, m_t);
ylim([-2.5 1.5]);
title('Message Signal');
xlabel('Time (s)');
ylabel('Amplitude');

% Generating the carrier signal
c_t = cos(2*pi*Fc*t);
subplot(2,2,2);
plot(t, c_t);
title('Carrier Signal');
xlabel('Time (s)');
ylabel('Amplitude');
ylim([-1.5 1.5]);

% Generating the modulated signal
u_t = m_t .* c_t;
subplot(2,2,3:4);
plot(t, u_t);
title('Modulated Signal');
xlabel('Time (s)');
ylabel('Amplitude');

% Plot Spectra
figure;
subplot(2,1,1);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(m_t))));
title('Spectrum of Message Signal');
xlabel('Frequency (Hz)');
ylabel('Amplitude');
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(u_t))));
title('Spectrum of Modulated Signal');
xlabel('Frequency (Hz)');
ylabel('Amplitude');

% Calculate power
u_pow = sum(u_t .^ 2) / N;
fprintf(1, 'Power of modulated signal u(t) = %f / %f\n\n', u_pow);

% Calculate Noise Power
SNR = 10;
n_pow = u_pow / (10 ^ (SNR/10));
fprintf(1, 'Noise power = %f\n\n', n_pow);


