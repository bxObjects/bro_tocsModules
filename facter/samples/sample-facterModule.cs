#!/usr/bin/env python

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/auth/bxRepos/bisos-pip/loadAsCs/py3/bin/exmpl-loadAs.cs
** File True Name: /bisos/git/auth/bxRepos/bisos-pip/loadAsCs/py3/bin/exmpl-loadAs.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

from bisos import b
from bisos.b import cs

from bisos.b import b_io

from bisos.basics import pathPlus
from pathlib import Path

# from bisos.loadAsCs import loadAsCs_seed
from bisos.tocsModules  import facterModule_seed

import collections

facterModule_seed.setup(
    seedType="common",
)

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
