#r "/home/hojelse/fsharp-tools/FsLexYacc.Runtime.dll"
#load "Absyn.fs"
#load "Absyn.fs"
#load "Machine.fs"
#load "CPar.fs"
#load "CLex.fs"
#load "Comp.fs"
#load "Contcomp.fs"
#load "Interp.fs"
#load "Parse.fs"
#load "ParseAndComp.fs"
#load "ParseAndContcomp.fs"
#load "ParseAndRun.fs"

open Absyn;;
open Absyn;;
open Machine;;
open CPar;;
open CLex;;
open Comp;;
open Contcomp;;
open Interp;;
open Parse;;
open ParseAndComp;;
open ParseAndContcomp;;
open ParseAndRun;;

(* 3 *)
fromFile "within.c";;

(* 2 *)
ParseAndRun.fromFile "fac.c"
ParseAndComp.compileToInsts (ParseAndRun.fromFile "fac.c");;
ParseAndComp.compile "fac";;

(* 3 *)
ParseAndComp.compileToInsts (ParseAndRun.fromFile "within.c");;
ParseAndComp.compileToFile (ParseAndRun.fromFile "within.c") "within.out";;