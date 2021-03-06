﻿using SI.Shared.Sif.Testclient.Common;
using SI.Shared.Sif.Testclient.Common.Entities;
using SI.Shared.Sif.Testclient.Common.Helpers;
using SI.Shared.Sif.Testclient.Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SI.Shared.Sif.Testclient.Console
{
    public static class SampleMethodes
    {
        public static CreateDocumentOKResponse CreateDocument(ServiceHelper serviceHelper, DocumentInfo documentInfo, CaseInfo caseInfo, ProjectInfo projectInfo)
        {
            Byte[] bytes = File.ReadAllBytes(@$"{documentInfo.File_Path}");
            String base64file = Convert.ToBase64String(bytes);

            CreateDocumentArgsParameterFilesItem file = new CreateDocumentArgsParameterFilesItem()
            {
                Title = documentInfo.File_Title,
                Format = documentInfo.File_Format,

                Base64Data = base64file
            };

            List<CreateDocumentArgsParameterFilesItem> files = new List<CreateDocumentArgsParameterFilesItem>();
            files.Add(file);

            CreateCaseWithProjectResponse createCaseWithProjectResponse = null;
            if (documentInfo.CreateCase)
            {
                createCaseWithProjectResponse = CreateCase(serviceHelper,caseInfo, projectInfo);

                documentInfo.CaseNumber = createCaseWithProjectResponse.createCaseOKResponse.CaseNumber;
            }

            CreateDocumentArgs createDocumentArgs = new CreateDocumentArgs(new CreateDocumentArgsParameter()
            {
                CaseNumber = documentInfo.CaseNumber,
                Title = documentInfo.Title,
                UnofficialTitle = documentInfo.UnofficialTitle,
                DocumentDate = documentInfo.DocumentDate,
                JournalDate = documentInfo.JournalDate,
                DispatchedDate = documentInfo.DispatchedDate,
                Category = documentInfo.Category,
                Status = documentInfo.Status,
                Files = files
            });

            CreateDocumentOKResponse createDocumentOKResponse = serviceHelper.DocumentService.CreateDocument(createDocumentArgs);

            CreateDocumentWithCaseResponse createDocumentWithFileStreamResponse = new CreateDocumentWithCaseResponse()
            {
                createDocumentOKResponse = createDocumentOKResponse,
                createCaseWithProjectResponse = createCaseWithProjectResponse ?? new CreateCaseWithProjectResponse()
            };


            return createDocumentOKResponse;
        }

        public static CreateCaseWithProjectResponse CreateCase(ServiceHelper serviceHelper, CaseInfo caseInfo, ProjectInfo projectInfo)
        {
            CreateProjectOKResponse createProjectOKResponse = null;
            if (caseInfo.CreateProject)
            {
                createProjectOKResponse = CreateProject(serviceHelper, projectInfo);

                caseInfo.Project = createProjectOKResponse.ProjectNumber;
            }

            CreateCaseArgsParameter createCaseArgsParameter = new CreateCaseArgsParameter()
            {
                Title = caseInfo.Title,
                Project = caseInfo.Project
            };

            CreateCaseOKResponse createCaseOKResponse = serviceHelper.CaseService.CreateCase(new CreateCaseArgs(createCaseArgsParameter));

            CreateCaseWithProjectResponse createCaseWithProjectResponse = new CreateCaseWithProjectResponse()
            {
                createCaseOKResponse = createCaseOKResponse,
                createProjectOKResponse = createProjectOKResponse ?? new CreateProjectOKResponse()
            };

            return createCaseWithProjectResponse;
        }

        public static CreateDocumentWithFileUploadResponse CreateDocumentWithFileUpload(ServiceHelper serviceHelper, DocumentInfo documentInfo, CaseInfo caseInfo, ProjectInfo projectInfo)
        {
            Byte[] bytes = File.ReadAllBytes(@$"{documentInfo.File_Path}");

            UploadArgs uploadArgsParameter = new UploadArgs(new UploadArgsParameter()
            {
                FileData = bytes.Select(b => b as object).ToList()
            });

            if (String.IsNullOrWhiteSpace(documentInfo.File_Format) == false)
            {
                uploadArgsParameter.Parameter.FileFormat = documentInfo.File_Format;
            }

            if (String.IsNullOrWhiteSpace(documentInfo.File_Title) == false)
            {
                uploadArgsParameter.Parameter.FileName = documentInfo.File_Title;
            }

            if (String.IsNullOrWhiteSpace(documentInfo.AdContextUser) == false)
            {
                uploadArgsParameter.Parameter.ADContextUser = documentInfo.AdContextUser;
            }
            
            if(String.IsNullOrWhiteSpace(documentInfo.User) == false)
            {
                uploadArgsParameter.Parameter.User = documentInfo.User;
            }

            UploadOKResponse uploadOKResponse = serviceHelper.FileService.Upload(uploadArgsParameter);
            
            CreateDocumentArgsParameterFilesItem file = new CreateDocumentArgsParameterFilesItem()
            {
                Title = documentInfo.File_Title,
                Format = documentInfo.File_Format,
                UploadedFileReference = uploadOKResponse.FileReference
            };

            List<CreateDocumentArgsParameterFilesItem> files = new List<CreateDocumentArgsParameterFilesItem>();
            files.Add(file);

            CreateDocumentArgsParameterFilesFromTemplateItem template = null;

            if (String.IsNullOrWhiteSpace(documentInfo.TemplateId) == false && 
                String.IsNullOrWhiteSpace(documentInfo.TemplateTitle) == false)
            {
                template = new CreateDocumentArgsParameterFilesFromTemplateItem()
                {
                    TemplateId = documentInfo.TemplateId,
                    Title = documentInfo.TemplateTitle
                };
            }

            CreateCaseWithProjectResponse createCaseWithProjectResponse = null;
            if (documentInfo.CreateCase)
            {
                createCaseWithProjectResponse = CreateCase(serviceHelper, caseInfo, projectInfo);

                documentInfo.CaseNumber = createCaseWithProjectResponse.createCaseOKResponse.CaseNumber;
            }

            CreateDocumentArgs createDocumentArgs = new CreateDocumentArgs(new CreateDocumentArgsParameter()
            {
                CaseNumber = documentInfo.CaseNumber,
                Title = documentInfo.Title,
                UnofficialTitle = documentInfo.UnofficialTitle,
                DocumentDate = documentInfo.DocumentDate,
                JournalDate = documentInfo.JournalDate,
                DispatchedDate = documentInfo.DispatchedDate,
                Category = documentInfo.Category,
                Status = documentInfo.Status,
                Files = files
            });

            if(template != null)
            {
                createDocumentArgs.Parameter.FilesFromTemplate = new[] { template };
            }

            CreateDocumentOKResponse createDocumentOKResponse = serviceHelper.DocumentService.CreateDocument(createDocumentArgs);

            CreateDocumentWithFileUploadResponse createDocumentWithFileStreamResponse = new CreateDocumentWithFileUploadResponse() 
            {
                uploadOKResponse = uploadOKResponse, 
                createDocumentOKResponse = createDocumentOKResponse,
                createCaseWithProjectResponse = createCaseWithProjectResponse ?? new CreateCaseWithProjectResponse()
            };

            return createDocumentWithFileStreamResponse;
        }

        public static CreateProjectOKResponse CreateProject(ServiceHelper serviceHelper, ProjectInfo projectInfo)
        {
            CreateProjectArgsParameter createProjectArgsParameter = new CreateProjectArgsParameter()
            {
                Title = projectInfo.Title,
            };

            CreateProjectOKResponse createProjectOKResponse = serviceHelper.ProjectService.CreateProject(
                new CreateProjectArgs(createProjectArgsParameter));

            return createProjectOKResponse;
        }

        /// <summary>
        /// Getting SIF version(se doc if you get Json deserialization)
        /// </summary>
        /// <returns></returns>
        public static string GetSIFVersion(ServiceHelper serviceHelper) 
        {
            string SIFVersion = serviceHelper.SupportService.GetSIFVersion();
            return SIFVersion;
        }

        public static SynchronizeEnterpriseOKResponse CreateOrUpdateEnterprise(ServiceHelper serviceHelper, string externalID, string name)
        {
            SynchronizeEnterpriseArgsParameter synchronizeEnterpriseArgsParameter = new SynchronizeEnterpriseArgsParameter()
            {
                ExternalID = externalID,
                Name = name
            };

            SynchronizeEnterpriseArgs synchronizeEnterpriseArgs = new SynchronizeEnterpriseArgs(synchronizeEnterpriseArgsParameter);

            SynchronizeEnterpriseOKResponse synchronizeEnterpriseOKResponse = serviceHelper.ContactService.SynchronizeEnterprise(synchronizeEnterpriseArgs);

            return synchronizeEnterpriseOKResponse;
        }

        public static GetEnterprisesOKResponse GetEnterprises(ServiceHelper serviceHelper) 
        {
            GetEnterprisesArgs getEnterpriseArgs = new GetEnterprisesArgs(
                new GetEnterprisesArgsParameter());

            GetEnterprisesOKResponse response = serviceHelper.ContactService.GetEnterprises(getEnterpriseArgs);

            return response;
        }

        public static GetEnterprisesOKResponseEnterprisesItem GetEnterprise(ServiceHelper serviceHelper, string externalID)
        {
            GetEnterprisesArgs getEnterpriseArgs = new GetEnterprisesArgs(
                new GetEnterprisesArgsParameter()
                {
                    ExternalID = externalID
                });

            GetEnterprisesOKResponse response = serviceHelper.ContactService.GetEnterprises(getEnterpriseArgs);

            GetEnterprisesOKResponseEnterprisesItem enterprisesItem;

            try
            {
                enterprisesItem = response.Enterprises.SingleOrDefault();
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("Enterprise search resultet in no enterprises", e);
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException("Enterprise search has more than one result. Recno shoud be unique, check you data", e);
            }

            return enterprisesItem;
        }

        public static CreateOrUpdateUserAndContactResponse CreateOrUpdateUserAndContact(ServiceHelper serviceHelper, UserInfo userInfo) 
        {
            SynchronizeContactPersonArgsParameter synchronizeContactPersonArgsParameter = new SynchronizeContactPersonArgsParameter()
            {
                ExternalId = userInfo.ExternalId,
                Active = userInfo.Active,
                FirstName = userInfo.FirstName,
                LastName = userInfo.LastName,
                Title = userInfo.Title,
                Enterprise = userInfo.Enterprise
            };

            SynchronizeContactPersonOKResponse synchronizeContactPersonOKResponse = serviceHelper.SynchronizeContact(synchronizeContactPersonArgsParameter);

            List<SynchronizeUserArgsParameterProfilesItem> profilesItems = new List<SynchronizeUserArgsParameterProfilesItem>();

            if (userInfo.ShoudHaveProfile)
            {
                profilesItems.Add(new SynchronizeUserArgsParameterProfilesItem()
                {
                    EnterpriseId = userInfo.Enterprise,
                    Role = "4",
                    FromDate = DateTime.Now,
                });
            }

            SynchronizeUserArgsParameter synchronizeUserArgsParameter = new SynchronizeUserArgsParameter()
            {
                ContactExternalId = userInfo.ExternalId,
                Profiles = profilesItems,
                Login = userInfo.Login,
                IsActive = userInfo.Active
            };

            SynchronizeUserOKResponse synchronizeUserOKResponse = serviceHelper.SynchronizeUser(synchronizeUserArgsParameter);

            CreateOrUpdateUserAndContactResponse createOrUpdateUserAndContactResponse = new CreateOrUpdateUserAndContactResponse()
            {
                synchronizeContactPersonOKResponse = synchronizeContactPersonOKResponse,
                synchronizeUserOKResponset = synchronizeUserOKResponse
            };

            return createOrUpdateUserAndContactResponse;
        }
    }
}
