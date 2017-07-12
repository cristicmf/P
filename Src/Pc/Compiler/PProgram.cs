using System;
using System.Collections.Generic;
using Microsoft.Formula.API.Generators;
using Microsoft.Pc.Domains;

namespace Microsoft.Pc
{
    public class PProgram
    {
        public bool IgnoreDecl;

        public PProgram(List<PLink_Root.ModuleContainsMachine> moduleContainsMachine)
        {
            ModuleContainsMachine = moduleContainsMachine;
            TypeDefs = new List<P_Root.TypeDef>();
            EnumTypeDefs = new List<P_Root.EnumTypeDef>();
            ModelTypes = new List<P_Root.ModelType>();
            Events = new List<P_Root.EventDecl>();
            Machines = new List<P_Root.MachineDecl>();
            MachineKinds = new List<P_Root.MachineKind>();
            MachineCards = new List<P_Root.MachineCard>();
            MachineStarts = new List<P_Root.MachineStart>();
            States = new List<P_Root.StateDecl>();
            Variables = new List<P_Root.VarDecl>();
            Transitions = new List<P_Root.TransDecl>();
            Functions = new List<P_Root.FunDecl>();
            AnonFunctions = new List<P_Root.AnonFunDecl>();
            Dos = new List<P_Root.DoDecl>();
            Annotations = new List<P_Root.Annotation>();
            Observes = new List<P_Root.ObservesDecl>();
            MachineExports = new List<P_Root.MachineExports>();
            InterfaceTypeDef = new List<P_Root.InterfaceTypeDef>();
            EventSetDecl = new List<P_Root.EventSetDecl>();
            EventSetContains = new List<P_Root.EventSetContains>();
            FunProtoDecls = new List<P_Root.FunProtoDecl>();
            MachineProtoDecls = new List<P_Root.MachineProtoDecl>();
            MachineSends = new List<P_Root.MachineSends>();
            MachineReceives = new List<P_Root.MachineReceives>();
            DependsOn = new List<P_Root.DependsOn>();
            IgnoreDecl = false;
            FunProtoCreates = new List<P_Root.FunProtoCreatesDecl>();
            AnyTypeDecl = new List<P_Root.AnyTypeDecl>();
        }

        public List<P_Root.AnyTypeDecl> AnyTypeDecl { get; }

        public List<P_Root.TypeDef> TypeDefs { get; }

        public List<P_Root.DependsOn> DependsOn { get; }

        public List<P_Root.EnumTypeDef> EnumTypeDefs { get; }

        public List<P_Root.ModelType> ModelTypes { get; }

        public List<P_Root.EventDecl> Events { get; }

        public List<P_Root.MachineDecl> Machines { get; }

        public List<P_Root.StateDecl> States { get; }

        public List<P_Root.VarDecl> Variables { get; }

        public List<P_Root.TransDecl> Transitions { get; }

        public List<P_Root.FunDecl> Functions { get; }

        public List<P_Root.AnonFunDecl> AnonFunctions { get; }

        public List<P_Root.DoDecl> Dos { get; }

        public List<P_Root.Annotation> Annotations { get; }

        public List<P_Root.ObservesDecl> Observes { get; }

        public List<P_Root.InterfaceTypeDef> InterfaceTypeDef { get; }

        public List<P_Root.EventSetDecl> EventSetDecl { get; }

        public List<P_Root.EventSetContains> EventSetContains { get; }

        public List<P_Root.MachineExports> MachineExports { get; }

        public List<P_Root.FunProtoDecl> FunProtoDecls { get; }

        public List<P_Root.MachineProtoDecl> MachineProtoDecls { get; }

        public List<P_Root.MachineReceives> MachineReceives { get; }

        public List<P_Root.MachineSends> MachineSends { get; }


        public List<P_Root.FunProtoCreatesDecl> FunProtoCreates { get; }

        public List<P_Root.MachineKind> MachineKinds { get; }

        public List<P_Root.MachineCard> MachineCards { get; }

        public List<P_Root.MachineStart> MachineStarts { get; }

        //module system related

        public List<PLink_Root.ModuleContainsMachine> ModuleContainsMachine { get; }

        public List<PLink_Root.ModuleDecl> ModuleDecl { get; private set; }

        public List<PLink_Root.ModulePrivateEvents> ModulePrivateEvents { get; private set; }

        public List<PLink_Root.ModuleName> ModuleName { get; private set; }

        public List<PLink_Root.TestDecl> TestDecl { get; private set; }

        public List<PLink_Root.RefinementDecl> RefinementDecl { get; private set; }

        public List<PLink_Root.ImplementationDecl> ImplementationDecl { get; private set; }

        public List<PLink_Root.ModuleDef> ModuleDef { get; private set; }

        public IEnumerable<ICSharpTerm> Terms
        {
            get
            {
                foreach (var at in AnyTypeDecl)
                    yield return at;

                foreach (var td in TypeDefs)
                    yield return td;

                foreach (var etd in EnumTypeDefs)
                    yield return etd;

                foreach (var md in ModelTypes)
                    yield return md;

                foreach (var ed in Events)
                    yield return ed;

                foreach (var md in Machines)
                    yield return md;

                foreach (var md in MachineCards)
                    yield return md;

                foreach (var md in MachineKinds)
                    yield return md;

                foreach (var md in MachineStarts)
                    yield return md;

                foreach (var s in States)
                    yield return s;

                foreach (var vd in Variables)
                    yield return vd;

                foreach (var td in Transitions)
                    yield return td;

                foreach (var fd in Functions)
                    yield return fd;

                foreach (var afd in AnonFunctions)
                    yield return afd;

                foreach (var di in Dos)
                    yield return di;

                foreach (var ann in Annotations)
                    yield return ann;

                foreach (var obs in Observes)
                    yield return obs;

                foreach (var evset in EventSetDecl)
                    yield return evset;

                foreach (var ev in EventSetContains)
                    yield return ev;

                foreach (var inter in InterfaceTypeDef)
                    yield return inter;

                foreach (var ex in MachineExports)
                    yield return ex;

                foreach (var fp in FunProtoDecls)
                    yield return fp;

                foreach (var mp in MachineProtoDecls)
                    yield return mp;

                foreach (var mr in MachineReceives)
                    yield return mr;

                foreach (var ms in MachineSends)
                    yield return ms;

                foreach (var fp in FunProtoCreates)
                    yield return fp;

                foreach (var d in DependsOn)
                    yield return d;

                foreach (var mc in ModuleContainsMachine)
                {
                    yield return mc;
                }
                foreach (var mn in ModuleName)
                {
                    yield return mn;
                }
                foreach (var mp in ModulePrivateEvents)
                {
                    yield return mp;
                }
                foreach (var md in ModuleDecl)
                {
                    yield return md;
                }
                foreach (var td in TestDecl)
                {
                    yield return td;
                }
                foreach (var rd in RefinementDecl)
                {
                    yield return rd;
                }
                foreach (var id in ImplementationDecl)
                {
                    yield return id;
                }
                foreach (var md in ModuleDef)
                {
                    yield return md;
                }
            }
        }

        public void Add(object item)
        {
            if (IgnoreDecl)
                return;
            if (item is P_Root.AnyTypeDecl)
                AnyTypeDecl.Add((P_Root.AnyTypeDecl) item);
            else if (item is P_Root.MachineSends)
                MachineSends.Add((P_Root.MachineSends) item);
            else if (item is P_Root.MachineReceives)
                MachineReceives.Add((P_Root.MachineReceives) item);
            else if (item is P_Root.MachineProtoDecl)
                MachineProtoDecls.Add((P_Root.MachineProtoDecl) item);
            else if (item is P_Root.FunProtoDecl)
                FunProtoDecls.Add((P_Root.FunProtoDecl) item);
            else if (item is P_Root.MachineExports)
                MachineExports.Add((P_Root.MachineExports) item);
            else if (item is P_Root.EventSetContains)
                EventSetContains.Add((P_Root.EventSetContains) item);
            else if (item is P_Root.EventSetDecl)
                EventSetDecl.Add((P_Root.EventSetDecl) item);
            else if (item is P_Root.InterfaceTypeDef)
                InterfaceTypeDef.Add((P_Root.InterfaceTypeDef) item);
            else if (item is P_Root.ObservesDecl)
                Observes.Add((P_Root.ObservesDecl) item);
            else if (item is P_Root.Annotation)
                Annotations.Add((P_Root.Annotation) item);
            else if (item is P_Root.DoDecl)
                Dos.Add((P_Root.DoDecl) item);
            else if (item is P_Root.AnonFunDecl)
                AnonFunctions.Add((P_Root.AnonFunDecl) item);
            else if (item is P_Root.FunDecl)
                Functions.Add((P_Root.FunDecl) item);
            else if (item is P_Root.TransDecl)
                Transitions.Add((P_Root.TransDecl) item);
            else if (item is P_Root.VarDecl)
                Variables.Add((P_Root.VarDecl) item);
            else if (item is P_Root.StateDecl)
                States.Add((P_Root.StateDecl) item);
            else if (item is P_Root.MachineDecl)
                Machines.Add((P_Root.MachineDecl) item);
            else if (item is P_Root.MachineCard)
                MachineCards.Add((P_Root.MachineCard) item);
            else if (item is P_Root.MachineKind)
                MachineKinds.Add((P_Root.MachineKind) item);
            else if (item is P_Root.MachineStart)
                MachineStarts.Add((P_Root.MachineStart) item);
            else if (item is P_Root.EventDecl)
                Events.Add((P_Root.EventDecl) item);
            else if (item is P_Root.ModelType)
                ModelTypes.Add((P_Root.ModelType) item);
            else if (item is P_Root.EnumTypeDef)
                EnumTypeDefs.Add((P_Root.EnumTypeDef) item);
            else if (item is P_Root.TypeDef)
                TypeDefs.Add((P_Root.TypeDef) item);
            else if (item is P_Root.DependsOn)
                DependsOn.Add((P_Root.DependsOn) item);
            else if (item is P_Root.FunProtoCreatesDecl)
                FunProtoCreates.Add((P_Root.FunProtoCreatesDecl) item);
            else
                throw new Exception("Cannot add into the Program : " + item);
        }
    }
}