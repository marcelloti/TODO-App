unit Main;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, StdCtrls, ExtCtrls,
  Buttons, DBCtrls, DBGrids, LCLType;

type

  { TmainForm }

  TmainForm = class(TForm)
    btnAddTask: TBitBtn;
    btnDeleteTask: TBitBtn;
    btnClearList: TBitBtn;
    TodoListBox: TCheckGroup;
    Image1: TImage;
    Label1: TLabel;
    inputTaskName: TLabeledEdit;
    procedure btnAddTaskClick(Sender: TObject);
    procedure btnClearListClick(Sender: TObject);
    procedure btnDeleteTaskClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Label1Click(Sender: TObject);
    procedure TodoListBoxClick(Sender: TObject);
  private

  public

  end;

var
  mainForm: TmainForm;

implementation

{$R *.lfm}

{ TmainForm }

procedure TmainForm.Label1Click(Sender: TObject);
begin

end;

procedure TmainForm.TodoListBoxClick(Sender: TObject);
begin

end;

procedure TmainForm.btnAddTaskClick(Sender: TObject);
  var taskName: String;
begin
  taskName := inputTaskName.Text;

  if (taskName = '') then begin
    Application.MessageBox('Type a task name to add it', 'Error', MB_ICONERROR);
    Exit;
  end;
  TodoListBox.Items.Add(taskName);

  inputTaskName.Text := '';
end;

procedure TmainForm.btnClearListClick(Sender: TObject);
  var Reply, BoxStyle: Integer;
  var Message: String;
begin
  BoxStyle := MB_ICONQUESTION + MB_YESNO;
  Message := 'Do you really want to delete all tasks ? ';

  Reply := Application.MessageBox(PChar(Message), 'Confirm', BoxStyle);

  if Reply = IDYES then begin
     TodoListBox.items.Clear;
  end;
end;

function ConfirmDelete(itemsToDeleteCounter: Integer; itemsToDeleteArrayOfNames: Array of String; itemsToDeleteArrayOfIndex: Array of Integer): boolean;
  var index: Integer;
  var TasksNameToDelete: String;
  var Reply, BoxStyle: Integer;
  var Message: String;
begin
    TasksNameToDelete := '';

    for index:=0 to itemsToDeleteCounter-1 do begin
      if (TasksNameToDelete <> '') then begin
        TasksNameToDelete := TasksNameToDelete + ', ' + itemsToDeleteArrayOfNames[index];
      end
      else
        TasksNameToDelete := itemsToDeleteArrayOfNames[index];
    end;

    BoxStyle := MB_ICONQUESTION + MB_YESNO;
    Message := ' Do you really want to delete these tasks: ' + TasksNameToDelete + ' ?';

    Reply := Application.MessageBox(PChar(Message), 'Confirm', BoxStyle);

    Result := false;
    if Reply = IDYES then begin
       Result := true;
    end;
end;

procedure DeleteItemAction(TodoListBox: TCheckGroup; itemNameToDelete: String);
var currentItem: String;
var index: Integer;
begin
    index := 0;

    for currentItem in TodoListBox.items do begin
      if (currentItem = itemNameToDelete) then begin
         TodoListBox.Items.Delete(index);
      end;
      index := index + 1;
    end;
end;

procedure TmainForm.btnDeleteTaskClick(Sender: TObject);
  var listCounter: Integer;
  var itemsToDeleteArrayOfIndex: Array of Integer;
  var itemsToDeleteArrayOfNames: Array of String;
  var itemsToDeleteCounter: Integer;
  var itemNameToDelete: String;
  var index: Integer;
  var Reply: Boolean;
begin
  itemsToDeleteCounter := 0;
  SetLength(itemsToDeleteArrayOfIndex, 1);
  SetLength(itemsToDeleteArrayOfNames, 1);

  listCounter := TodoListBox.Items.Count;

  for index:=0 to listCounter-1 do begin
      if TodoListBox.Checked[index] then begin

        itemsToDeleteArrayOfIndex[itemsToDeleteCounter] := index;
        itemsToDeleteArrayOfNames[itemsToDeleteCounter] := PChar(TodoListBox.Items[index]);

        itemsToDeleteCounter := itemsToDeleteCounter + 1;

        SetLength(itemsToDeleteArrayOfIndex, itemsToDeleteCounter + 1);
        SetLength(itemsToDeleteArrayOfNames, itemsToDeleteCounter + 1);
      end;
  end;

  if (itemsToDeleteCounter > 0) then begin
    Reply := ConfirmDelete(itemsToDeleteCounter, itemsToDeleteArrayOfNames, itemsToDeleteArrayOfIndex);

    if (Reply = true) then begin
      for itemNameToDelete in itemsToDeleteArrayOfNames do begin
        if (itemNameToDelete <> '') then begin
          DeleteItemAction(TodoListBox, itemNameToDelete);
        end;
      end;
    end;
  end
  else begin
    Application.MessageBox('Select at least one item to delete', 'Error', MB_ICONERROR);
  end;
end;

procedure TmainForm.FormCreate(Sender: TObject);
begin

end;

end.

