import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44372/',
  redirectUri: baseUrl,
  clientId: 'ChengyiV2_App',
  responseType: 'code',
  scope: 'offline_access ChengyiV2',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ChengyiV2',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44355',
      rootNamespace: 'ChengyiV2',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
