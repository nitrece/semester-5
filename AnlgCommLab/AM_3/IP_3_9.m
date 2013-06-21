% Illustrative Problem 3.9
% ------------------------
clc;
clear all;
close all;

% Details given in the question
Fc = 250;
t0 = 0.15;
a = 0.85;

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
figure;
subplot(2,1,1);
plot(t, m_t);
ylim([-2.5 1.5]);
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
u_t = (2/a)*c_t + m_t.*c_t;
figure;
subplot(2,1,1);
plot(t, u_t);
title('Modulated Signal');
xlabel('Time (s)');
ylabel('Amplitude');
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(u_t))));
title('Spectrum of Modulated Signal');
xlabel('Frequency (Hz)');
ylabel('Amplitude');

% Demodulate the modulated signal
md_t = am_envelope_detect(u_t, 1/Fs, 1/50);

% Plot the demodulated signal
figure;
subplot(2,1,1);
plot(t, md_t);
title('Demodulated Signal (using Envelope Detector)');
xlabel('Time (s)');
ylabel('Amplitude');
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(md_t))));
title('Spectrum of Demodulated Signal (using Envelope Detector)');
xlabel('Frequency (Hz)');
ylabel('Amplitude');

% Demodulate the modulated signal with noise
un_t = awgn(u_t, 20);
mdn_t = am_envelope_detect(un_t, 1/Fs, 1/50);

% Plot the demodulated signal with noise
figure;
subplot(2,1,1);
plot(t, mdn_t);
title('Demodulated Signal (with noise, SNR = 20dB)');
xlabel('Time (s)');
ylabel('Amplitude');
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(mdn_t))));
title('Spectrum of Demodulated Signal (with noise, SNR = 20dB)');
xlabel('Frequency (Hz)');
ylabel('Amplitude');

% 
% function y = am_envelope_detect(x, Ts, time_const)
% % Function to simulate envelope detection
% N = length(x);
% y = zeros(1, N);
% amp = 0;
% tp = 0;
% for i = 1 : N
%     if(x(1, i) > (amp * exp(-tp / time_const)))
%         amp = x(1, i);
%         tp = 0;
%     else
%         tp = tp + Ts;
%     end
%     y(1, i) = amp * exp(-tp / time_const);
% end
% end
% 
