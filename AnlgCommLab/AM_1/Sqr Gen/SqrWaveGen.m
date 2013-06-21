
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
plotTitle = 'Square wave';
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
    x = zeros(size(t));
    for j = 1 : N
        rot = mod(Fm * t(j), 1);
        x(j) = Amp * (2 * round(rot) - 1);
    end
	figure(hFig), plot(t, x, 'LineWidth', plotLineWidth);
    title(plotTitle);
    xlabel(plotXlabel);
    ylabel(plotYlabel);
    ylim(plotYlim);
    grid on;
    saveas(hFig, [plotTitle, sprintf(' (%d cycles) ', Cycles(i)), plotSaveType]);
end
close(hFig);
disp('Square Wave Generation: All figures saved in current directory.');
disp(' ');

