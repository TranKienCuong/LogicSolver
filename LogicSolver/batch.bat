rem batch.bat
rem %1 represents the file name with no extension.
pdflatex -jobname=output %1
convert -density 200 -alpha on output.pdf output.png
