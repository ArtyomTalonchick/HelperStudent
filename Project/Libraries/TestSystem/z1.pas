program z1;
var
  a, b, c, d, t, s, x, y : qword;
  f1, f2 : text;
function max(a, b : qword) : qword;
  begin
    if a > b
       then max := a
       else max := b;
  end;
begin
  assign(f1, 'input.txt'); reset(f1);
  assign(f2, 'output.txt'); rewrite(f2);

  read(f1, a, b, c, d);
  if a > b 
     then begin
            t := a; a := b; b := t;
          end;
  if c > d 
     then begin
            t := c; c := d; d := t;
          end;
  x := max (b, d); y := a + c;
  write(f2, x * y);
  
  close(f1); close(f2);
end.