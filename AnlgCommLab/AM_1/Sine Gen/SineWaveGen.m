
% Clean up MATLAB Environment
clc;
clear all;
close all;

% Question specifications
Cycles = [1, 10, 100];
Fs  = 10 * 10^3;
Fm  = 1  * 10^3;
Vpp = 2;

% Give names for Plots
plotTitle = 'Sine wave';
plotXlabel = 'Time (s)';
plotYlabel = 'Amplitude (V)';
plotSaveType = '.jpg';
plotLineWidth = 1;
plotYlim = [-Vpp, Vpp];

% Calculate initial values before plot
Ts = 1 / Fs;
Amp = Vpp / 2;

% Calculate and plot for all cases (cycles)
hFig = figure;
hold off;
for i = 1 : length(Cycles)
	N = round((Fs / Fm) * Cycles(i));
	t = 0 : Ts : ((N-1)*Ts);
	x = Amp * sin(2 * pi * Fm * t);
	figure(hFig), plot(t, x, 'LineWidth', plotLineWidth);
    title(plotTitle);
    xlabel(plotXlabel);
    ylabel(plotYlabel);
    ylim(plotYlim);
    grid on;
    saveas(hFig, [plotTitle, sprintf(' (%d cycles) ', Cycles(i)), plotSaveType]);
end
close(hFig);
disp('Sine Wave Generation: All figures saved in current directory.');
disp(' ');

