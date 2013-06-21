% Illustrative Problem 3.2
% ------------------------
clc;
clear all;
close all;

% Details given in the question
Fc = 250;
t0 = 0.1;
T0 = 0.2;

% Assumed values
Tstart = -0.4;
Tstop = 0.4;
Fs = 2.5 * 10^2.5;

% Generating time
Ts = 1 / Fs;
t = Tstart : Ts : Tstop;
N = length(t);

% Generating the message signal
tk = mod(t - (T0/2), T0) - (T0/2);
m_t = (sin(pi*100*tk)./(pi*tk));
for i = 1 : N
    if(isnan(m_t(1, i)))
        m_t(1, i) = 100;
    end
end
subplot(2,2,1);
plot(t, m_t);
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
fprintf(1, 'Power of modulated signal u(t) = %f\n\n', u_pow);

% Calculate Noise Power
SNR = 10;
n_pow = u_pow / (10 ^ (SNR/10));
fprintf(1, 'Noise power = %f\n\n', n_pow);

