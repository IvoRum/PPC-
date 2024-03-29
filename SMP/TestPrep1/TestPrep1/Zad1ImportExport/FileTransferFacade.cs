﻿namespace Zad1ImportExport;

public class FileTransferFacade
{
    private Iinport _Inport;
    private Iexport _Export;

    public FileTransferFacade(Iinport inport, Iexport export)
    {
        _Inport = inport;
        _Export = export;
    }

    public File fileTransfer(File file)
    {
        _Inport.import(file);
        // Logic code here
        return _Export.export(file);
    }
}