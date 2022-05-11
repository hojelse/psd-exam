#load "Contfun.fs"
#load "Contimp.fs"
#load "Icon.fs"

open Contfun;;
open Contimp;;
open Icon;;

let examEx1 = Icon.Write(Icon.FromTo(1,10));;
Icon.run examEx1;;

open Icon;;
run (Every(Write(FromTo(1, 10))));;

run (Every(Write(Prim("*", FromTo(1, 10), FromTo(1, 10)))));;

run (Every(Write(Prim("*", FromTo(1, 10), And(Write(CstS "\n"), FromTo(1, 10))))));;

run (Every(Write(Random(1,10,3))));;