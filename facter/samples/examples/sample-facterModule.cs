#!/usr/bin/env python

from bisos.b import cs
import collections

from bisos.tocsModules  import facterModule_seed

def examples_csu() -> None:

    od = collections.OrderedDict
    cmnd = cs.examples.cmndEnter
    literal = cs.examples.execInsert

    cs.examples.menuChapter(f'*Seed Extensions*')

    oneModuleFile = "./facterModuleSample.py"
    oneTargetFile = "./targets/examples.tgt"

    uploadPars = od([('upload', oneModuleFile)])
    targetFilePars = od([('upload', oneModuleFile), ('targetFile', oneTargetFile) ])
    modulePars = od([('upload', oneModuleFile), ('targetFile', oneTargetFile), ('facterParName', 999) ])

    cs.examples.menuChapter('= Sample TOCS Facter Module  Commands=')

    cmnd('targetRun', pars=uploadPars , args="""localhost""")

    cmnd('targetRun', pars=uploadPars , args="""localhost""",
         wrapper=f"echo 127.0.0.1 |",
         )

    cmnd('targetRun', pars=targetFilePars , args="""localhost""",
         wrapper=f"echo 127.0.0.1 |",
         )

    cmnd('targetRun', pars=modulePars, comment=f"""# facterParName is defined inside of the {oneModuleFile}""",)
