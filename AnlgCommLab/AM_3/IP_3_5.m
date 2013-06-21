% Illustrative Problem 3.5
% ------------------------
clc;
clear all;
close all;

% Details given in the question
lpf_Fc = 250;
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
c_t = cos(2*pi*lpf_Fc*t);
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
u_t = m_t .* c_t;
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

% Create a Low Pass Filter
lpf_N    = 128;      % Order
lpf_Fc   = 250;      % Cutoff Frequency
lpf_flag = 'scale';  % Sampling Flag
lpf_h    = fir1(lpf_N, lpf_Fc/(Fs/2), 'low', blackman(lpf_N+1), lpf_flag);
lpf_sz   = length(lpf_h);
lpf_sz2  = floor(lpf_sz / 2);

% Demodulate the modulated signal
md1_t = u_t .* c_t;
md2_t = conv(md1_t, lpf_h);
md_t = 2 * md2_t(1, (1 + lpf_sz2) : (length(md2_t) - (lpf_sz - lpf_sz2 - 1)));

% Plot the demodulated signal
figure;
subplot(2,1,1);
plot(t, md1_t);
title('Modulated Signal multiplied with the Carrier');
xlabel('Time (s)');
ylabel('Amplitude');
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(md1_t))));
title('Modulated Signal multiplied with the Carrier');
xlabel('Frequency (Hz)');
ylabel('Amplitude');
figure;
subplot(2,1,1);
plot(t, md_t);
title('Demodulated Signal (after passing through LPF)');
xlabel('Time (s)');
ylabel('Amplitude');
subplot(2,1,2);
plot(linspace(-Fs/2, Fs/2, N), abs(fftshift(fft(md_t))));
title('Spectrum of Demodulated Signal (after passing through LPF)');
xlabel('Frequency (Hz)');
ylabel('Amplitude');
